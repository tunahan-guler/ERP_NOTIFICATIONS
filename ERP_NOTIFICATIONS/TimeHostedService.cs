using System.Diagnostics;

namespace ERP_NOTIFICATIONS
{
    public class TimeHostedService : IHostedService
    {

        private readonly IServiceScopeFactory scopeFactory;
        private Timer _timer;

        public TimeHostedService(IServiceScopeFactory scopeFactory)
        {
            this.scopeFactory = scopeFactory;
        }

        public Task StartAsync(CancellationToken cancellationToken)
        {
            TimeSpan interval = new TimeSpan(0,0,5);

            _timer = new Timer(DoWorkCodlean, null, TimeSpan.Zero, interval);

            return Task.CompletedTask;
        }
        private async void DoWorkCodlean(object? state)
        {
            Console.WriteLine("Çalıştım");
        }

        public Task StopAsync(CancellationToken cancellationToken)
        {
            _timer?.Dispose();
            return Task.CompletedTask;
        }
    }
}