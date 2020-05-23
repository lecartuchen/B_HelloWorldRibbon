namespace B_HelloWorld_RibbonPanel
{
    using System;
    using System.IO;
    using System.Linq;
    using System.Reflection;
    using System.Collections.Generic;
    using System.Windows.Media.Imaging;

    using Autodesk.Revit.UI;
    using Autodesk.Revit.UI.Selection;
    using Autodesk.Revit.DB;

    public class Invoke : IExternalCommand
    {
        public Result Execute(ExternalCommandData commandData, ref string message, ElementSet elements)
        {
            string path = Assembly.GetExecutingAssembly().Location;
            String exeConfigPath = Path.GetDirectoryName(path) + "..\\..\\..\\" + "B_HelloWorld_RibbonPanel.dll";
            String exeConfigPath2 = Path.GetDirectoryName(path) + "..\\..\\..\\" + "Hazen_RibbonPanel.addin";

            string strCommandName = "ThisApplication";

            byte[] assemblyBytes = File.ReadAllBytes(exeConfigPath);

            Assembly objAssembly = Assembly.Load(assemblyBytes);
            IEnumerable<Type> myIEnumerableType = GetTypesSafely(objAssembly);
            foreach (Type objType in myIEnumerableType)
            {
                if (objType.IsClass)
                {
                    if(objType.Name.ToLower() == strCommandName.ToLower())
                    {
                        object ibaseObject = Activator.CreateInstance(objType);
                        object[] arguments = new object[] { commandData, exeConfigPath2, elements };
                        object result = null;

                        result = objType.InvokeMember("Execute", BindingFlags.Default | BindingFlags.InvokeMethod, null, ibaseObject, arguments);

                        break;
                    }
                }
            }

            return Result.Succeeded;
        }

        private static IEnumerable<Type> GetTypesSafely(Assembly assembly)
        {
            try
            {
                return assembly.GetTypes();
            }
            catch (ReflectionTypeLoadException ex)
            {
                return ex.Types.Where(x => x != null);
            }
        }
    }
}
