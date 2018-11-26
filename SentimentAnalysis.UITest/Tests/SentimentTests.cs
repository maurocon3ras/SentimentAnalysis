using NUnit.Framework;

using Xamarin.UITest;

using SentimentAnalysis.Shared;

namespace SentimentAnalysis.UITest
{
    public class SentimentTests : BaseTest
    {
        public SentimentTests(Platform platform) : base(platform)
        {
        }

        [Test]
        public void SentimentPage_SubmitHappyText_ResultShouldBeHappyFaceEmoji()
        {
            //Arrange
            const string happyText = "Estoy feliz de participar en la .NET Conf CL v2018";

            //Act
            SentimentPage.EnterText(happyText);
            SentimentPage.TapSubmitButton();
            SentimentPage.WaitForNoActivityIndicator();

            //Assert
            Assert.AreEqual(EmojiConstants.HappyFaceEmoji, SentimentPage.EmojiResultsText);
        }

        [Test]
        public void SentimentPage_SubmitSadText_ResultShouldBeSadFaceEmoji()
        {
            //Arrange
            const string sadText = "Triste";

            //Act
            SentimentPage.EnterText(sadText);
            SentimentPage.TapSubmitButton();
            SentimentPage.WaitForNoActivityIndicator();

            //Assert
            Assert.AreEqual(EmojiConstants.SadFaceEmoji, SentimentPage.EmojiResultsText);
        }

        [Test]
        public void SentimentPage_SubmitNeutralText_ResultShouldBeNeutralFaceEmoji()
        {
            //Arrange
            const string neutralText = "Disturbios en la Araucanía";

            //Act
            SentimentPage.EnterText(neutralText);
            SentimentPage.TapSubmitButton();
            SentimentPage.WaitForNoActivityIndicator();

            //Assert
            Assert.AreEqual(EmojiConstants.NeutralFaceEmoji, SentimentPage.EmojiResultsText);
        }
    }
}
