using System;
using System.Net;
using System.Security.Cryptography.X509Certificates;
using static System.Net.WebRequestMethods;

namespace programme_reseau
{
	internal class Program
	{
		static void Main(string[] args)
		{
			// https://codeavecjonathan.com/res/exemple.html

			string urlHtml = "https://codeavecjonathan.com/res/exemple.html";
			string urlTxt = "https://codeavecjonathan.com/res/exemple.txt";
			string urlPizzas1 = "https://codeavecjonathan.com/res/pizzas1.json";
			string urlPapillon = "https://codeavecjonathan.com/res/pizzas1.json";

			var webClient = new WebClient();

            Console.WriteLine("Accès au réseau...");

			try
			{
				string reponseHtml = webClient.DownloadString(urlHtml);
				string reponseTxt = webClient.DownloadString(urlTxt);
				string reponseJson = webClient.DownloadString(urlPizzas1);

				webClient.DownloadFile(urlPapillon, "pap.jpg");
                Console.WriteLine("Téléchargement terminé");

                Console.WriteLine(reponseHtml);
				Console.WriteLine(reponseTxt);
				Console.WriteLine(reponseJson);

			}
			catch(Exception ex)
			{

                Console.WriteLine("ERREUR RESEAU :" + ex.Message);
            }

        }					  		
	}
}
