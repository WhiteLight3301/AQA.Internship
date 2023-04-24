namespace AQA.Enver.Internship.PageObjectPattern.Base;

public class BasePage
{
        private string formName;
        private IWebElement uniqElement;
    
        public BasePage(IWebElement uniqElement, string formName)
        {
            this.uniqElement = uniqElement;
            this.formName = formName;
        }
        
        public bool IsFormOpen()
        {
            return uniqElement.Displayed;
        }
}