namespace GenericsandCollections.Generics
{
    public  class GenericMethod
    {
       
        public T DisplayData<T>(T Data)
        {
            return Data;
        }
        public T AddNumbers<T>(T Data,T Data2) where T:IConvertible
        {
            if (typeof(T) == typeof(string))
            {
                string stringData = Data.ToString();
                string stringData2 = Data2.ToString();
                return (T)(object)(stringData + stringData2);
            }

            dynamic convertedData = Convert.ChangeType(Data, typeof(T));

            dynamic convertedData2 = Convert.ChangeType(Data2, typeof(T));

            return convertedData + convertedData2;

        }
    }
}
