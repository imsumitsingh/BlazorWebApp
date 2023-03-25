namespace BlazorWebApp.Models
{
    public class CustomModal
    {
        public string HeaderText { get; set; } = "Confirmation";
        public string BodyText { get; set; } = "Do you want to delete ?";
        public string Type { get; set; } = ModalType.Primary;
        public string LeftBuutonText { get; set; } = "No";
        public string LeftBuutonClass { get; set; } = "btn-danger";
        public string RightBuutonText { get; set; } = "Yes";
        public string RightBuutonClass { get; set; } = "btn-success";
       
    }
    public static class ModalType
    {
        public static string Warning { get; set; } = "bg-warning";
        public static string Success { get; set; } = "bg-success";
        public static string Primary { get; set; } = "bg-primary";
        public static string information { get; set; } = "bg-info";
    }
}

