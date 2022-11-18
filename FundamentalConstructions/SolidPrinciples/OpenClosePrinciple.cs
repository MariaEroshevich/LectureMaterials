namespace SolidPrinciples
{
    abstract class AdapterBase
    {
        public abstract bool Request(string url);
    }

    class AjaxAdapter : AdapterBase
    {
        public override bool Request(string url)
        {
            //
        }
    }

    class NodeAdapter : AdapterBase
    {
        public override bool Request(string url)
        {
            //
        }
    }

    class HttpRequester : AdapterBase
    {
        private readonly AdapterBase Adapter;

        public HttpRequester(AdapterBase adapter)
        {
            Adapter = adapter;
        }

        public bool Fetch(string url)
        {
            return Adapter.Request(url);
        }
    }
}
