using Imc.Models;

namespace Imc
{
    public static class AppState
    {
        public static List<ImcModel> History { get; set; } = [];
        public static event EventHandler<EventArgs> OnChanged;
        
        public static void NotifyChanges(object? sender, EventArgs e)
        {
            OnChanged?.Invoke(sender, e);
        }
    }
}
