using System;
using System.Diagnostics;
using FundManagerDashboard.Core.DataServices;
using FundManagerDashboard.Core.ViewModels;
using ReactiveUI;
using Splat;

namespace FundManagerDashboard.Core
{
    public class AppBootstrapper : ReactiveObject, IScreen
    {
        public AppBootstrapper(IMutableDependencyResolver container = null, RoutingState router = null)
        {
            Router = router ?? new RoutingState();
            _container = container ?? Locator.CurrentMutable;
            RegisterParts();
            try
            {
                Router.Navigate.Execute(_container.GetService<IShellViewModel>());
            }
            catch (Exception exception)
            {
                Debug.WriteLine(exception);
                throw;
            }
        }

        public AppBootstrapper RegisterPart<T, TF>()
        {
            _container.Register(() => Activator.CreateInstance(typeof(TF)), typeof (T));
            return this;
        }

        public AppBootstrapper RegisterConstantPart<T, TF>()
        {
            _container.RegisterConstant(Activator.CreateInstance(typeof(TF)), typeof(T));
            return this;
        }

        private void RegisterParts()
        {
            _container.RegisterConstant(this, typeof(IScreen));

            _container.RegisterLazySingleton(()=>new LocalInMemoryStockService(), typeof(IStockService));
            _container.RegisterLazySingleton(() => new FundSummaryService(_container.GetService<IStockService>()), typeof(ITotalSummaryService), "Fund");
            _container.RegisterLazySingleton(() => new EquitySummaryService(_container.GetService<IStockService>()), typeof(ITotalSummaryService), "Equity");
            _container.RegisterLazySingleton(() => new BondSummaryService(_container.GetService<IStockService>()), typeof(ITotalSummaryService), "Bond");

            _container.Register(
                () => Activator.CreateInstance(typeof(AddItemViewModel), _container.GetService<IScreen>(), _container.GetService<IStockService>()),
                typeof(IAddItemViewModel));
            _container.Register(
                () => Activator.CreateInstance(typeof(StockListViewModel), _container.GetService<IScreen>(), _container.GetService<IStockService>(), _container.GetService<ITotalSummaryService>("Fund")),
                typeof(IStockListViewModel));

            _container.Register(
                () =>Activator.CreateInstance(typeof (TotalSummaryViewModel), _container.GetService<IScreen>(), _container.GetService<ITotalSummaryService>("Fund"), _container.GetService<ITotalSummaryService>("Equity"), _container.GetService<ITotalSummaryService>("Bond")),
                typeof (ITotalSummaryViewModel));

            _container.Register(
                () =>
                    Activator.CreateInstance(typeof (ShellViewModel), _container.GetService<IScreen>(),
                        _container.GetService<IAddItemViewModel>(), _container.GetService<IStockListViewModel>(), _container.GetService<ITotalSummaryViewModel>()), typeof (IShellViewModel));
        }


        private IMutableDependencyResolver _container;

        public RoutingState Router { get; protected set; }
    }
}