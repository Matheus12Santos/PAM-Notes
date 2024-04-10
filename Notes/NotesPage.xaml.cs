namespace Notes;

public partial class NotesPage : ContentPage
{
    string path = Path.Combine(FileSystem.AppDataDirectory, "notes.txt");
    string content = "";

    public NotesPage()
    {
        InitializeComponent();
        if (File.Exists(path))
        {
            FileEditor.Text = File.ReadAllText(path);
        }
    }

    private void SaveButton_Clicked(object sender, EventArgs e)
    {
        //Pegar o que o usuario digitou 
        content = FileEditor.Text;

        //Criar o arquivo com esse conteudo
        File.WriteAllText(path, content);
    }

    private void DeleteButton_Clicked(Object sender, EventArgs e)
    {
        if (File.Exists(path))
        {
            //Apagar o arquivo e exibir uma mensagem
            File.Delete(path);
            FileEditor.Text = "";
            DisplayAlert("Sucesso", "Arquivo deletado com sucesso", "OK");
        }
    }
}