using System.Text.RegularExpressions;

namespace SwitchIPSEditor
{
    internal static class TabManager
    {
        static Dictionary<TabControl, Dictionary<string, string>> ExtendedNames = new Dictionary<TabControl, Dictionary<string, string>>();
        internal static void AddTab(this TabControl tabControl, string tabName, string extendedTabName, params Control[] subControls)
        {
            var ext = Path.GetExtension(tabName);
            var res = default(string[]);
            var match = default(Match);
            var originalTabName = tabName;

            tabControl.Visible = true;

            if (tabControl.HasTab(originalTabName))
            {
                if (tabControl.HasTabWithExtendedName(extendedTabName))
                    return;

                while (tabControl.HasTab(tabName))
                {
                    match = Regex.Match(tabName, @"\(([\d]+)\)");
                    if (match.Success && match.Groups.Count == 2)
                        tabName = $"{originalTabName} ({(Convert.ToInt32(match.Groups[1].Value) + 1)}){ext}";
                    else
                        tabName = tabName.Replace(ext, $" (1){ext}");
                }
            }
            var tabPage = new TabPage();
            tabPage.Text = tabName;
            tabPage.Controls.AddRange(subControls);
            tabControl.TabPages.Add(tabPage);
            if (!ExtendedNames.ContainsKey(tabControl))
                ExtendedNames.Add(tabControl, new Dictionary<string, string>());
            ExtendedNames[tabControl].Add(tabName, extendedTabName);
        }

        internal static TabPage? GetTab(this TabControl tabControl, string tabName)
        {
            if (!tabControl.HasTab(tabName))
                return null;

            foreach (TabPage page in tabControl.TabPages)
                if (page.Text == tabName)
                    return page;

            return null;
        }

        internal static bool HasTab(this TabControl tabControl, string tabName)
        {
            if (!ExtendedNames.ContainsKey(tabControl))
                return false;
            return ExtendedNames[tabControl].ContainsKey(tabName);
        }

        internal static bool HasTabWithExtendedName(this TabControl tabControl, string extendedTabName)
        {
            if (!ExtendedNames.ContainsKey(tabControl))
                return false;
            return ExtendedNames[tabControl].Any(kvp => kvp.Value == extendedTabName);
        }

        internal static void RemoveTab(this TabControl tabControl, string extendedTabName)
        {
            var tabName = tabControl.GetTabNameFromExtendedName(extendedTabName);
            tabControl.TabPages.Remove(tabControl.GetTab(tabName));
            ExtendedNames[tabControl].Remove(tabName);
            if (ExtendedNames[tabControl].Count <= 0)
            {
                ExtendedNames.Remove(tabControl);
                tabControl.Visible = false;
            }
        }

        internal static string GetTabNameFromExtendedName(this TabControl tabControl, string extendedTabName)
        {
            var search = ExtendedNames[tabControl].Select(kvp => kvp).Where(kvp => kvp.Value == extendedTabName);
            if (!search.Any())
                throw new Exception($"Couldn't find the extended name ({extendedTabName})!");
            return search.First().Key;
        }

        internal static string GetExtendedNameFromTabName(this TabControl tabControl, string tabName)
        {
            return ExtendedNames[tabControl][tabName];
        }

        internal static void SetExtendedNameFromTabName(this TabControl tabControl, string tabName, string extendedTabName)
        {
            ExtendedNames[tabControl][tabName] = extendedTabName;
        }
    }
}
