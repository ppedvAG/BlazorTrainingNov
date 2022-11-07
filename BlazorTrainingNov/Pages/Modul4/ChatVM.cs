namespace BlazorTrainingNov.Pages.Modul4
{
    public class ChatVM
    {
        public Action OnAdd;
        public List<NachrichtenModel> NachrichtenListe { get; set; } = new List<NachrichtenModel>();
        public void Add(string _text)
        {
            NachrichtenListe.Add(new NachrichtenModel { Text = _text });
            OnAdd?.Invoke();
        }
    }
}
