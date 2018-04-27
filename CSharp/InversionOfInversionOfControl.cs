namespace Project.Features.Mapping
{

    public class IndexMappingProvider : IIndexMappingProvider
    {
        private IIndexableMapper<B> _b;
        private IIndexableMapper<C> _c;
        private IIndexableMapper<D> _d;
        private IIndexableMapper<E> _e;
        private IIndexableMapper<F> _f;
        private IIndexableMapper<G> _g;
        private IIndexableMapper<H> _h;
        private IIndexableMapper<I> _i;
        


        public IndexMappingProvider(IIndexableMapper<A> a, 
                IIndexableMapper<B> b, 
                IIndexableMapper<C> c,
                IIndexableMapper<D> d,
                IIndexableMapper<E> e,
                IIndexableMapper<F> f,
                IIndexableMapper<G> g,
                IIndexableMapper<H> h,
                IIndexableMapper<I> i)
        {
            _b = b;
            _c = c;
            _d = d;
            _e = e;
            _f = f;
            _g = g;
            _h = h;
            _i = i;
        }

        public IEnumerable<IIndexable> Map<T>(T content)
        {
            if (content is A)
            {
                return _a.Map(content as A);
            }

            if (content is B)
            {
                return _b.Map(content as B);
            }
            
            if (content is C)
            {
                return _c.Map(content as C);
            }

            if (content is D)
            {
                return _d.Map(content as D);
            }

            if (content is E)
            {
                return _e.Map(content as E);
            }

            if (content is F)
            {
                return _f.Map(content as F);
            }

            if (content is G)
            {
                return _g.Map(content as G);
            }

            if (content is H)
            {
                return _h.Map(content as H);
            }

            return null;
        }

        public IIndexable MapContent(IContent content)
        {
            if (content.ContentType.Alias == aliasA)
            {
                return _a.MapContent(content);
            }

            if (content.ContentType.Alias == aliasB)
            {
                return _b.MapContent(content);
            }

            return _c.MapContent(content);
        }
    }
}
