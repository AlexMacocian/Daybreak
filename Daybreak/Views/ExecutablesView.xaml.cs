﻿using Daybreak.Controls;
using Daybreak.Models;
using Daybreak.Services.Configuration;
using Daybreak.Services.ViewManagement;
using Microsoft.Win32;
using System;
using System.Collections.ObjectModel;
using System.Extensions;
using System.Linq;
using System.Windows.Controls;
using System.Windows.Data;

namespace Daybreak.Views
{
    /// <summary>
    /// Interaction logic for ExecutablesView.xaml
    /// </summary>
    public partial class ExecutablesView : UserControl
    {
        private readonly IConfigurationManager configurationManager;
        private readonly IViewManager viewManager;
        public ObservableCollection<GuildwarsPath> Paths { get; } = new();

        public ExecutablesView(
            IConfigurationManager configurationManager,
            IViewManager viewManager)
        {
            this.configurationManager = configurationManager.ThrowIfNull(nameof(configurationManager));
            this.viewManager = viewManager.ThrowIfNull(nameof(viewManager));
            this.InitializeComponent();
            this.GetPaths();
        }

        private void GetPaths()
        {
            this.Paths.AddRange(this.configurationManager.GetConfiguration().GuildwarsPaths);
        }

        private void BackButton_Clicked(object sender, EventArgs e)
        {
            this.viewManager.ShowView<SettingsCategoryView>();
        }

        private void AddButton_Clicked(object sender, EventArgs e)
        {
            var newPath = new GuildwarsPath();
            this.Paths.Add(newPath);
            if (this.Paths.Count == 1)
            {
                this.SetPathAsDefault(newPath);
            }
        }

        private void SaveButton_Clicked(object sender, EventArgs e)
        {
            var config = this.configurationManager.GetConfiguration();
            config.GuildwarsPaths = this.Paths.ToList();
            this.configurationManager.SaveConfiguration(config);
            this.viewManager.ShowView<SettingsCategoryView>();
        }

        private void GuildwarsPathTemplate_DefaultClicked(object sender, EventArgs e)
        {
            var path = sender.As<GuildwarsPathTemplate>()?.DataContext?.As<GuildwarsPath>();
            this.SetPathAsDefault(path);
        }

        private void GuildwarsPathTemplate_RemoveClicked(object sender, EventArgs e)
        {
            var path = sender.As<GuildwarsPathTemplate>()?.DataContext?.As<GuildwarsPath>();
            this.Paths.Remove(path);
            if (this.Paths.Count > 0 && path.Default is true)
            {
                this.SetPathAsDefault(this.Paths.First());
            }
        }

        private void SetPathAsDefault(GuildwarsPath gwPath)
        {
            foreach (var path in this.Paths)
            {
                path.Default = false;
            }
            gwPath.Default = true;
            var view = CollectionViewSource.GetDefaultView(this.Paths);
            view.Refresh();
        }
    }
}
