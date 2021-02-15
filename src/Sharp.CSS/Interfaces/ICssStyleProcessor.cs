using Sharp.CSS.CssStyleSets;

namespace Sharp.CSS.Interfaces
{
    public interface ICssStyleProcessor
    {
        /// <summary>
        /// Generates CSS content with a class selector
        /// </summary>
        /// <param name="className">Name of the class</param>
        /// <param name="cssContent">CSS content without class selector</param>
        /// <returns>CSS with a class selector</returns>
        string WrapInClassSelector(string className, string cssContent);

        /// <summary>
        /// Generates CSS content with a class selector
        /// </summary>
        /// <param name="className">Name of the class</param>
        /// <param name="set">CSS set</param>
        /// <returns>CSS with a class selector</returns>
        string Process(string className, StyleSet set);

        /// <summary>
        /// Generates CSS content without a class name
        /// </summary>
        /// <param name="set">CSS set</param>
        /// <returns>Raw CSS content</returns>
        string Process(StyleSet set);
    }
}
