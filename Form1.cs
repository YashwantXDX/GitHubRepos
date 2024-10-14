using Newtonsoft.Json.Linq;

namespace GitHubRepos
{
    public partial class Form1 : Form
    {
        // to call GitHub API
        private static readonly HttpClient client = new HttpClient();

        public Form1()
        {
            InitializeComponent();
        }

        // Method call when fetch is clicked
        private async void btnFetch_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();  // Get the username entered

            if (string.IsNullOrEmpty(username))
            {
                MessageBox.Show("Please enter a GitHub username.");  // Show error if no username is entered
                return;
            }

            // To show in GUI the repositories
            await FetchRepositoriesAsync(username);
        }

        
        private async Task FetchRepositoriesAsync(string username)
        {
            try
            {
                string apiUrl = $"https://api.github.com/users/{username}/repos"; 
                client.DefaultRequestHeaders.Add("User-Agent", "C# App");

                // HTTP call for API
                HttpResponseMessage response = await client.GetAsync(apiUrl);

                // Used NewtonSoft to parse the JSON code
                if (response.IsSuccessStatusCode)
                {
                    string jsonResponse = await response.Content.ReadAsStringAsync();  
                    JArray repos = JArray.Parse(jsonResponse); 

                    lstRepositories.Items.Clear();

                    // To fetch and print the repos from the username. It will be in the form of List
                    foreach (var repo in repos)
                    {
                        string repoName = repo["name"].ToString();
                        lstRepositories.Items.Add(repoName); 
                    }

                    if (repos.Count == 0)
                    {
                        MessageBox.Show("No repositories found for this user.");
                    }
                }
                else
                {
                    MessageBox.Show("Error fetching repositories. Make sure the username is correct.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
            }
        }
    }
}
