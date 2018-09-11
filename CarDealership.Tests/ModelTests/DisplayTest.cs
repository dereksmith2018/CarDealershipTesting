using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using CarDealership.Models;

namespace CarDealership.Test
{
  [TestClass]
  public class ModelsDisplayTest
  {
    [TestMethod]
    public void Story_GetPerson1_String()
    {
      //Arrange
      Story story = new Story("person1", "person2", "animal", "exclamation", "verb", "noun");
      //Act
      string person1 = "person1";
      string person2 = "person2";
      string animal = "animal";
      string exclamation = "exclamation";
      string verb = "verb";
      string noun = "noun";
      //Assert
      Assert.AreEqual(person1, story.GetPerson1());
      Assert.AreEqual(person2, story.GetPerson2());
      Assert.AreEqual(animal, story.GetAnimal());
      Assert.AreEqual(exclamation, story.GetExclamation());
      Assert.AreEqual(verb, story.GetVerb());
      Assert.AreEqual(noun, story.GetNoun());
    }
  }
}
