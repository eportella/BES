using System;
using System.Linq;
using System.Threading.Tasks;
namespace BES.TruthTable
{
    internal static class Extension
    {
        public static async Task AddAsync(this Model model, Output.Interface output)
        {
            if (output == default(Output.Interface))
                throw new InvalidOperationException();

            if (await model.AnyAsync<Output.Interface>())
                throw new InvalidOperationException();

            await Task.Run(() =>
            {
                var outputColumn = Cell.Service.NewCollection();
                outputColumn.Add(output);
                model.Cells.Add(outputColumn);
            });
        }

        public static async Task AddAsync(this Model model, Variable.Interface variable)
        {
            if (variable == default(Variable.Interface))
                throw new InvalidOperationException();

            if (!await model.AnyAsync<Output.Interface>())
                throw new InvalidOperationException();

            if (!await model.AnyAsync<Alias.Interface>(variable.Name))
                throw new InvalidOperationException();

            await Task.Run(() =>
            {
                var variableColumn = Cell.Service.NewCollection();
                variableColumn.Add(variable);
                model.Cells.Add(variableColumn);
            });
        }

        public static async Task<bool> AnyAsync<T>(this Model model) where T : Cell.Interface
        {
            return await Task.Run(() => model.Cells.Any(a => a.Any(b => b is T)));
        }

        public static async Task<bool> AnyAsync<TAlias>(this Model model, Alias.Name.Struct name) where TAlias : Alias.Interface
        {
            return await Task.Run(() => model.Cells.Any(a => a.Any(b => b is TAlias && ((TAlias)b).Name == name)));
        }
    }
}
