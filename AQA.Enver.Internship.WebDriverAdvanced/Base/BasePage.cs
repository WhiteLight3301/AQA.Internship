namespace AQA.Enver.Internship.WebDriverAdvanced.Base;

public class BasePage
{
        private string _pageName;
        private IWebElement _uniqElement;
    
        public BasePage(IWebElement uniqElement, string pageName)
        {
            this._uniqElement = uniqElement;
            this._pageName = pageName;
        }
        
        public bool IsFormOpen()
        {
            return _uniqElement.Displayed;
        }
}