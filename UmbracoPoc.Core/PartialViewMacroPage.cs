using BlueLeet.UCodeFirst.Macros;
using BlueLeet.UCodeFirst.Proxy.Abstraction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace UmbracoPoc.Core
{
    public abstract class PartialViewMacroPage<T> : Umbraco.Web.Macros.PartialViewMacroPage
        where T : UCodeFirstMacroTypeBase
    {
        private readonly Lazy<T> lazyMacroFactory;

        /// <summary>
        /// Initializes a new instance of the <see cref="PartialViewMacroPage{T}"/> class.
        /// </summary>
        public PartialViewMacroPage()
        {
            lazyMacroFactory = new Lazy<T>(ResolveMacroData);
        }

        /// <summary>
        /// Gets the typed macro model.
        /// </summary>
        public T Macro
        {
            get
            {
                return lazyMacroFactory.Value;
            }
        }

        private T ResolveMacroData()
        {
            var factory = DependencyResolver.Current.GetService<IMacroTypeProxyFactory>();
            var typeToBuild = typeof(T);
            var macro = factory.Make(Model, typeToBuild);

            return macro as T;

            //var factory = ServiceLocator.Current.GetInstance<IMacroTypeProxyFactory>();
            //var typeToBuild = typeof(T);
            //var macro = factory.Make(Model, typeToBuild);

            //return macro as T;
        }
    }
}
