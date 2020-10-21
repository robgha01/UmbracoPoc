using System.Collections.Generic;
using BlueLeet.UCodeFirst.DataTypes;
using BlueLeet.UCodeFirst.Structure.Entities.GridSets;
using Umbraco.Core.Models;

namespace UmbracoPoc.Core.DataTypes
{
    /// <summary>
    /// The dropdown hair color.
    /// </summary>
    [DataType("Umbraco.Grid", DataType.GridFrontPage, ValueStorageType.Ntext)]
    public class GridFrontPage : DataTypeBase
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GridFrontPage"/> class.
        /// </summary>
        /// <param name="existingPreValues">
        /// The existing pre values.
        /// </param>
        public GridFrontPage(IDictionary<string, object> existingPreValues) : base(existingPreValues)
        {
            var config = new Umbraco.Web.PropertyEditors.GridConfiguration();

        }
    }

    public class GridConfigurationBuilder
    {
        public GridConfigurationBuilder()
        {
            Configuration = new GridConfiguration();
        }

        public GridConfigurationBuilder(GridConfiguration configuration)
        {
            Configuration = configuration;
        }

        public Umbraco.Web.PropertyEditors.GridConfiguration Configuration { get; }


    }
}
