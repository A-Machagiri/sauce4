using NUnit.Framework;
using TechTalk.SpecFlow;
using PageObjects.Login;
using Utilities.WebUtilities;

[Binding]
public class LoginSteps
{
    private LoginPage _loginPage;

    public LoginSteps(LoginPage loginPage)
    {
        _loginPage = loginPage;
    }

    [Given("I am on the login page")]
    public void GivenIAmOnTheLoginPage()
    {
        // Navigate to login page
    }

    [When("I enter valid credentials")]
    public void WhenIEnterValidCredentials()
    {
        _loginPage.EnterCredentials("standard_user", "secret_sauce");
    }

    [When("I enter invalid credentials")]
    public void WhenIEnterInvalidCredentials()
    {
        _loginPage.EnterCredentials("invalid_user", "wrong_password");
    }

    [Then("I should be redirected to the homepage")]
    public void ThenIShouldBeRedirectedToTheHomepage()
    {
        // Assert homepage is displayed
    }

    [Then("I should see an error message")]
    public void ThenIShouldSeeAnErrorMessage()
    {
        string errorMessage = _loginPage.GetErrorMessage();
        Assert.AreEqual("Epic sadface: Username and password do not match any user in this service", errorMessage);
    }
}