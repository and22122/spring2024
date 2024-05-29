public class Word
{
    private String _text;
    private bool _isHidden;

    public Word(String text)
    {
        _text = text;
        _isHidden = false;
    }

    public String getText()
    {
        if (_isHidden)
        {
            String accum = "";

            for (int i = 0; i < _text.Length; i ++)
            {
                accum += "_";
            }

            return accum;
        }
        else
        {
            return _text;
        }
    }

    public bool wordIsHidden()
    {
        return _isHidden;
    }

    public void hide()
    {
        _isHidden = true;
    }
}