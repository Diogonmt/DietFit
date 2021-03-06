﻿using DietFit.Common;
using DietFit.Model;
using DietFit.Controllers;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Basic Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234237

namespace DietFit.Views
{
    /// <summary>
    /// A basic page that provides characteristics common to most applications.
    /// </summary>
    public sealed partial class MarcarConsulta : Page
    {

        private NavigationHelper navigationHelper;
        private ObservableDictionary defaultViewModel = new ObservableDictionary();
        private CriarConsultaController controller;
        /// <summary>
        /// This can be changed to a strongly typed view model.
        /// </summary>
        public ObservableDictionary DefaultViewModel
        {
            get { return this.defaultViewModel; }
        }

        /// <summary>
        /// NavigationHelper is used on each page to aid in navigation and 
        /// process lifetime management
        /// </summary>
        public NavigationHelper NavigationHelper
        {
            get { return this.navigationHelper; }
        }
        
        public MarcarConsulta()
        {
            this.InitializeComponent();
            this.navigationHelper = new NavigationHelper(this);
            this.navigationHelper.LoadState += navigationHelper_LoadState;
            this.navigationHelper.SaveState += navigationHelper_SaveState;
            comboBox.Items.Add("07");
            comboBox.Items.Add("08");
            comboBox.Items.Add("09");
            comboBox.Items.Add("10");
            comboBox.Items.Add("11");
            comboBox.Items.Add("12");
            comboBox.Items.Add("13");
            comboBox.Items.Add("14");
            comboBox.Items.Add("15");
            comboBox.Items.Add("16");
            comboBox.Items.Add("17");
            comboBox.Items.Add("18");
            comboBox1.Items.Add("00");
            comboBox1.Items.Add("30");
            for (int i = 2016; i < 2050; i++)
            {
                comboBox4.Items.Add(i.ToString());
            }
            for (int i = 1; i < 32; i++)
            {
                comboBox2.Items.Add(i.ToString());
            }
            comboBox3.Items.Add("Janeiro");
            comboBox3.Items.Add("Fevereiro");
            comboBox3.Items.Add("Março");
            comboBox3.Items.Add("Abril");
            comboBox3.Items.Add("Maio");
            comboBox3.Items.Add("Junho");
            comboBox3.Items.Add("Julho");
            comboBox3.Items.Add("Agosto");
            comboBox3.Items.Add("Setembro");
            comboBox3.Items.Add("Outubro");
            comboBox3.Items.Add("Novembro");
            comboBox3.Items.Add("Dezembro");

        }

        /// <summary>
        /// Populates the page with content passed during navigation. Any saved state is also
        /// provided when recreating a page from a prior session.
        /// </summary>
        /// <param name="sender">
        /// The source of the event; typically <see cref="Common.NavigationHelper"/>
        /// </param>
        /// <param name="e">Event data that provides both the navigation parameter passed to
        /// <see cref="Frame.Navigate(Type, Object)"/> when this page was initially requested and
        /// a dictionary of state preserved by this page during an earlier
        /// session. The state will be null the first time a page is visited.</param>
        private void navigationHelper_LoadState(object sender, LoadStateEventArgs e)
        {
        }

        /// <summary>
        /// Preserves state associated with this page in case the application is suspended or the
        /// page is discarded from the navigation cache.  Values must conform to the serialization
        /// requirements of <see cref="Common.SuspensionManager.SessionState"/>.
        /// </summary>
        /// <param name="sender">The source of the event; typically <see cref="Common.NavigationHelper"/></param>
        /// <param name="e">Event data that provides an empty dictionary to be populated with
        /// serializable state.</param>
        private void navigationHelper_SaveState(object sender, SaveStateEventArgs e)
        {
        }

        #region NavigationHelper registration

        /// The methods provided in this section are simply used to allow
        /// NavigationHelper to respond to the page's navigation methods.
        /// 
        /// Page specific logic should be placed in event handlers for the  
        /// <see cref="Common.NavigationHelper.LoadState"/>
        /// and <see cref="Common.NavigationHelper.SaveState"/>.
        /// The navigation parameter is available in the LoadState method 
        /// in addition to page state preserved during an earlier session.

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            this.controller = (CriarConsultaController)e.Parameter;   
            fillList();
        }

        protected override void OnNavigatedFrom(NavigationEventArgs e)
        {
            navigationHelper.OnNavigatedFrom(e);
        }

        #endregion


        private void fillList()
        {
            foreach (Utilizador u in controller.getUtilizadores())
            {
                if (!u.getIsnutricionista() && !u.getIspt())
                {
                    listBox.Items.Add(u.getUserName());
                }
            }
        }

       

        private void listBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            DateTime date =new DateTime(Convert.ToInt32(comboBox4.SelectedValue), comboBox3.SelectedIndex + 1, Convert.ToInt32(comboBox2.SelectedValue), Convert.ToInt32(comboBox.SelectedValue), Convert.ToInt32(comboBox1.SelectedValue), 0);
            controller.marcarConsulta((String)listBox.SelectedItem, date);
            Alerta alerta;
            try
            {
                alerta = controller.getApp().getAlertas().getAlertaByUsername(controller.getApp().getUtilizadorByUser((String)listBox.SelectedItem));
                alerta.addAlerta("Consulta marcada por " + controller.getNutricionista().getPnome() + " em " + DateTime.Today.ToString());
            }
            catch (NullReferenceException ex)
            {
                String mensagem = "Consulta marcada por " + this.controller.getNutricionista().getPnome() + " em " + DateTime.Today.ToString();
                alerta = new Alerta(controller.getApp().getUtilizadorByUser((String)listBox.SelectedItem), mensagem);
                controller.getApp().getAlertas().addAlerta(alerta);
            }
        }

        private void textBox2_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
       
        private void button1_Click(object sender, RoutedEventArgs e)
        {
            DateTime date = new DateTime(Convert.ToInt32(comboBox4.SelectedValue), comboBox3.SelectedIndex + 1, Convert.ToInt32(comboBox2.SelectedValue), Convert.ToInt32(comboBox.SelectedValue), Convert.ToInt32(comboBox1.SelectedValue), 0);
            Utilizador user = controller.getUtilizadorbyUsername((String)listBox.SelectedItem);
            controller.getConsultabyDateandUser(date, user).consultaFeita();
            
        }
    }
}
