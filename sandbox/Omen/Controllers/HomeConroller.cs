using Microsoft.AspNetCore.Mvc;
using Microsoft.ML;
using System.IO;
using MyAspNetCoreApp.Models;
using Microsoft.Extensions.Logging;

namespace MyAspNetCoreApp.Controllers
{
    public class HomeController : Controller
    {
        private static readonly string modelPath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "sentiment_model.zip");
        private readonly MLContext mlContext;
        private readonly ITransformer mlModel;
        private readonly PredictionEngine<SentimentData, SentimentPrediction> predEngine;
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
            mlContext = new MLContext();
            if (!System.IO.File.Exists(modelPath))
            {
                throw new FileNotFoundException($"Model file not found at {modelPath}");
            }
            mlModel = mlContext.Model.Load(modelPath, out _);
            predEngine = mlContext.Model.CreatePredictionEngine<SentimentData, SentimentPrediction>(mlModel);
        }

        [HttpGet]
        public IActionResult Index(string sentimentText)
        {
            if (!string.IsNullOrEmpty(sentimentText))
            {
                var result = PredictSentiment(new SentimentData { SentimentText = sentimentText });
                bool isPositive = result.Score > 0;
                ViewData["SentimentResult"] = isPositive ? "Positive" : "Negative";
                ViewData["SentimentText"] = sentimentText;
                ViewData["SentimentScore"] = result.Score;
                _logger.LogInformation($"Sentiment: {sentimentText}, Prediction: {(isPositive ? "Positive" : "Negative")}, Score: {result.Score}");
            }
            return View();
        }

        [HttpPost]
        public IActionResult AnalyzeSentiment([FromBody] SentimentData input)
        {
            var result = PredictSentiment(input);
            bool isPositive = result.Score > 0;
            return Json(new { prediction = isPositive ? "Positive" : "Negative", score = result.Score });
        }

        private SentimentPrediction PredictSentiment(SentimentData input)
        {
            return predEngine.Predict(input);
        }
    }
}