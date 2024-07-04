using Data.Entities;
using OxyPlot;
using OxyPlot.Axes;
using OxyPlot.Series;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace View.Component
{
    public class DashboardViewModel
    {
        public PlotModel PieChartModel { get; private set; }
        public PlotModel LineChartModel { get; private set; }

        public DashboardViewModel(IEnumerable<Appointment> appointments)
        {
            PieChartModel = CreatePieChartModel(appointments);
            LineChartModel = CreateLineChartModel(appointments);
        }

        private PlotModel CreatePieChartModel(IEnumerable<Appointment> appointments)
        {
            var model = new PlotModel { Title = "Appointments by Service" };
            var pieSeries = new PieSeries();

            var serviceCounts = appointments.GroupBy(a => a.Service?.Name)
                                            .Select(g => new { ServiceName = g.Key, Count = g.Count() })
                                            .ToList();

            foreach (var serviceCount in serviceCounts)
            {
                pieSeries.Slices.Add(new PieSlice(serviceCount.ServiceName, serviceCount.Count));
            }

            model.Series.Add(pieSeries);
            return model;
        }

        private PlotModel CreateLineChartModel(IEnumerable<Appointment> appointments)
        {
            var model = new PlotModel { Title = "Appointments Over Time" };
            var lineSeries = new LineSeries();

            var appointmentsByDate = appointments.GroupBy(a => a.Date?.Date)
                                                 .Select(g => new { Date = g.Key, Count = g.Count() })
                                                 .OrderBy(x => x.Date)
                                                 .ToList();

            foreach (var appointment in appointmentsByDate)
            {
                lineSeries.Points.Add(new DataPoint(DateTimeAxis.ToDouble(appointment.Date), appointment.Count));
            }

            model.Series.Add(lineSeries);
            model.Axes.Add(new DateTimeAxis { Position = AxisPosition.Bottom, StringFormat = "yyyy-MM-dd" });
            model.Axes.Add(new LinearAxis { Position = AxisPosition.Left, Minimum = 0 });

            return model;
        }
    }

}
