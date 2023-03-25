namespace BlazorWebApp.Models
{
    public class ShowHideModal
    {
        public string Showing { get; set; } = "";
        public string Display { get; set; } = "none";
        public bool Visible { 
            get {
                if (string.IsNullOrEmpty(Showing) && Display=="none")
                {
                    return false;
                }
            return true;
            } set {

                if (value)
                {
                    Showing = "show";
                    Display = "block";
                }
                else
                {
                    
                    Showing = "";
                    Display = "none";
                }
            
            } } 

    }
}
