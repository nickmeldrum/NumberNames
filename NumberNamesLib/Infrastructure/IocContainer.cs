using Autofac;
using NumberNamesLib.Formatters;

namespace NumberNamesLib.Infrastructure {
    public class IocContainer {
        public static readonly IContainer Container;

        static IocContainer() {
            var builder = new ContainerBuilder();

            builder.RegisterType<ThreeDigitFormatter>();
            builder.RegisterType<NegativeFormatter>();
            builder.RegisterType<ZeroFormatter>();
            builder.RegisterType<UnitFormatter>();
            builder.RegisterType<TensFormatter>();
            builder.RegisterType<HundredsFormatter>();
            builder.RegisterType<NumberNameFormatter>();
            builder.RegisterType<RecombinationFormatter>();
            Container = builder.Build();
        }
    }
}
