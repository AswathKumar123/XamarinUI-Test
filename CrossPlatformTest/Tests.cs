using System;
using System.IO;
using System.Linq;
using NUnit.Framework;
using Xamarin.UITest;
using Xamarin.UITest.Queries;

namespace CrossPlatformTest
{
    //[TestFixture(Platform.Android)]
    [TestFixture(Platform.iOS)]
    public class Tests
    {
        IApp app;
        Platform platform;

        public Tests(Platform platform)
        {
            this.platform = platform;
        }

        [SetUp]
        public void BeforeEachTest()
        {
            app = AppInitializer.StartApp(platform);
        }

        [Test]
        public void AppLaunches()
        {
            app.Screenshot("First screen.");
        }

        //[Test]
        //public void NewTest()
        //{
        //   // app.Repl();

        //    app.Tap(x => x.Text("First item"));
        //    app.Back();
        //    app.Tap(x => x.Text("Second item"));
    //}

        [Test]
        public void TestMethod()
        {
            

            app.Tap(x => x.Id("content"));
            app.Back();
            app.Tap(x => x.Id("action_bar_root"));
            app.Back();
            app.Tap(x => x.Text("Add"));           
            app.EnterText(x => x.Text("Item name"), "Seventh Item");
            app.DismissKeyboard();
            app.Tap(x => x.Marked("Save"));
            app.Tap(x => x.Text("Add"));           
            app.EnterText(x => x.Text("Item name"), "Eight Item");
            app.DismissKeyboard();
            app.Tap(x => x.Marked("Save"));
            app.Tap(x => x.Text("Add"));           
            app.EnterText(x => x.Text("Item name"), "9th Item");
            app.DismissKeyboard();
            app.Tap(x => x.Marked("Save"));
            app.Tap(x => x.Text("Add"));                       
            app.EnterText(x => x.Text("Item name"), "10th Item");
            app.DismissKeyboard();
            app.Tap(x => x.Marked("Save"));
            app.Tap(x => x.Text("Add"));                     
            app.EnterText(x => x.Text("Item name"), "11th Item");
            app.DismissKeyboard();
            app.Tap(x => x.Marked("Save"));
            app.Tap(x => x.Text("Add"));                    
            app.EnterText(x => x.Text("Item name"), "12th Item");
            app.DismissKeyboard();
            app.Tap(x => x.Marked("Save"));
            app.Tap(x => x.Text("Add"));                    
            app.EnterText(x => x.Text("Item name"), "13th Item");
            app.DismissKeyboard();
            app.Tap(x => x.Marked("Save"));
            app.Tap(x => x.Text("Add"));                    
            app.EnterText(x => x.Text("Item name"), "14th Item");
            app.DismissKeyboard();
            app.Tap(x => x.Marked("Save"));
            app.Tap(x => x.Text("Add"));                       
            app.EnterText(x => x.Text("Item name"), "15th Item");
            app.DismissKeyboard();
            app.Tap(x => x.Marked("Save"));
            app.Tap(x => x.Text("Add"));          
            app.EnterText(x => x.Text("Item name"), "16th Item");
            app.DismissKeyboard();
            app.Tap(x => x.Marked("Save"));
            app.WaitForElement(x => x.Text("Item name10th Item"));
            app.ScrollDownTo(x => x.Text("Item name15th Item"));
            var elementCount = app.Query(x => x.Id("action_bar_root").All().Text("Item name13th Item")).Count();
            //app.Repl();
            Assert.That(elementCount, Is.EqualTo(1), "This element is not present");
            app.ScrollUpTo(x => x.Text("First item"));
            app.SwipeLeftToRight();
            app.SwipeRightToLeft();
            var elementCount2 = app.Query(x => x.Id("action_bar_root").All().Text("Third item")).Count();
            Assert.That(elementCount2, Is.EqualTo(1), "This element is not present");








        }


        
    }
}
