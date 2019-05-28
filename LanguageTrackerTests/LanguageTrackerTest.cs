using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;
using LanguageTracker.Controllers;
using LanguageTracker.Models;

namespace LanguageTrackerTests
{
	[TestClass]
	public class LanguageTrackerTest
	{
		[TestMethod]
		public void TestReadFile()
		{
			//load in the file
			Stream file = File.OpenRead("C:\\Users\\Mike\\Source\\Repos\\LanguageTracker\\LanguageTracker\\ACTFLScores.csv");

			//check that the method fails in the right context
			Assert.IsFalse(ReadFileMethod.ReadFile(null));

			//check that the method runs correctly when passed the right argument
			Assert.IsTrue(ReadFileMethod.ReadFile(file));
		}
	}
}
