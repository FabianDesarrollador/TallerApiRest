﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using TallerApis.xamarin.Model;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Newtonsoft.Json;

namespace TallerApis.xamarin.View
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class PublicacionPage : ContentPage
	{
		public PublicacionPage ()
		{
            InitializeComponent();
            CargarPublications();
		}

        private void CargarPublications()
        {
            
            {
                HttpClient client = new HttpClient();

            client.BaseAddress = new Uri("https://192.168.1.13");
            var request = client.GetAsync("TallerApis/api/Publicacion").Result;
            if (request.IsSuccessStatusCode)
            {
                var responseJson = request.Content.ReadAsStringAsync().Result;
                var response = JsonConvert.DeserializeObject<List<Publicacion>>(responseJson);
                    listpublicaciones.ItemsSource = response;
               
            }
            }

        }
    }
}