// using System;
// using System.Text;
// using OpenQA.Selenium;
// using OpenQA.Selenium.Chrome;
// using OpenQA.Selenium.Firefox;

// namespace Vaquinha.AutomatedUITests
// {
// 	public class DriverFactory
//     {
//         private IWebDriver _driver;

//         // Construtor da classe. 
//         public DriverFactory()
//         {
//             ChromeOptions options = new ChromeOptions();
//             options.AddArgument("--headless");
            
//             // Inicializa o browser utilizando o ChromeDriver que está no caminho C:\WebDriver
//             ChromeDriverService service = ChromeDriverService.CreateDefaultService("C:\\WebDriver\\");
            
//             // Faz criação de porta para abrir o browser.
//             // service.Port = new Random().Next(64000, 64800);

//             // Inicializa o IWebDriver do selenium, é ele que disponibiliza as consultas e manipulacoes das paginas. 
//             _driver = new ChromeDriver(service, options);
//             // _driver = new ChromeDriver("C:\\WebDriver\\", options);
//             _driver.Manage().Window.Maximize();
//         }

//         // Navega para determinada URL
//         public void NavigateToUrl(String url)
//         {            
//             _driver.Navigate().GoToUrl(url);
//         }

//         // Finaliza driver e serviço.
//         public void Close()
//         {
//             _driver.Quit();
//         }

//         // Disponibiliza driver.
//         public IWebDriver GetWebDriver()
//         {
//             return _driver;
//         }
//     }
// }