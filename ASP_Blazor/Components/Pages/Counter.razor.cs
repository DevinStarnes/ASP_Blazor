using Microsoft.AspNetCore.Components;

namespace ASP_Blazor.Components.Pages
{
    public partial class Counter
    {
        private int currentCount = 0;
		string text = "";
		string divText = "Mouse out";
		string searchResult = "";

		private void IncrementCount(Microsoft.AspNetCore.Components.Web.MouseEventArgs e) => currentCount++;

		private void OnInput(ChangeEventArgs e) => text = (string)e.Value!;

		private void MouseOver(Microsoft.AspNetCore.Components.Web.MouseEventArgs e) => divText = "Mouse over";

		private void MouseOut(Microsoft.AspNetCore.Components.Web.MouseEventArgs e) => divText = "Mouse out";
		private void OnClick(Microsoft.AspNetCore.Components.Web.MouseEventArgs e)
		{
			text = "";
		}

		async Task Search()
		{
			searchResult = "Searching...";
			await Task.Delay(2000);
			searchResult = $"Found {Random.Shared.Next()} results!";
		}
	}
}