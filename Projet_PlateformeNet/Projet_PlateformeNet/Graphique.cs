using System.Collections.Generic;
using System.Windows.Forms.DataVisualization.Charting;


    class Graphique
    {
        private Dictionary<string, Series> series = new Dictionary<string, Series>(); //dictionnaire avec les series du graphique
        

        public Graphique()
        {
            series.Add("Température", PointDegre);
            series.Add("Humidité", PointEau);
            series.Add("Pression", PointPression);
            series.Add("Vitesse du vent", PointVent);
        }

        public Series PointDegre { get; } = new Series()
        {
            Name = "Température",
            Color = System.Drawing.Color.Yellow,
            IsVisibleInLegend = true,
            IsXValueIndexed = false,
            ChartType = SeriesChartType.Line
            
        };

        public Series PointEau { get; } = new Series()
        {
            Name = "Humidité",
            Color = System.Drawing.Color.LightBlue,
            IsVisibleInLegend = true,
            IsXValueIndexed = false,
            ChartType = SeriesChartType.Line
        };

        public Series PointPression { get; } = new Series()
        {
            Name = "Pression",
            Color = System.Drawing.Color.Black,
            IsVisibleInLegend = true,
            IsXValueIndexed = false,
            ChartType = SeriesChartType.Line
        };


        public Series PointVent { get; } = new Series()
        {
            Name = "Vitesse du vent",
            Color = System.Drawing.Color.Gray,
            IsVisibleInLegend = true,
            IsXValueIndexed = false,
            ChartType = SeriesChartType.Line
        };
        public Dictionary<string, Series> Series { get => series; set => series = value; }
    }

