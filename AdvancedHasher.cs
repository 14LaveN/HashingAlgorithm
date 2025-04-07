namespace HashingAlgorithm;

public static class AdvancedHasher
{
    public static ulong ComputeHash(string? input)
    {
        if (string.IsNullOrEmpty(input))
            return 0;

        // Константы на основе крупных простых чисел
        const ulong prime1 = 0xC6A4A7935BD1E995;
        const ulong prime2 = 0x9E3779B97F4A7C15;
        const ulong prime3 = 0x87C37B91114253D5;
        const ulong prime4 = 0x4CF5AD432745937F;
        const ulong prime5 = 0x94D049BB133111EB;

        // Начальное значение хэша
        ulong hash = 0x123456789ABCDEF0;
        ulong length = (ulong)input.Length;

        // Основной цикл обработки
        for (int i = 0; i < input.Length; i += 8)
        {
            ulong chunk = 0;

            for (int j = 0; j < 8 && i + j < input.Length; j++)
            {
                chunk |= (ulong)input[i + j] << (j * 8);
            }

            // Первичное перемешивание
            chunk *= prime1;
            chunk ^= chunk >> 47;
            chunk *= prime2;

            hash ^= chunk;
            hash *= prime3;

            hash ^= (chunk << 17) | (chunk >> 47);
            hash *= prime4;
        }

        // Финальное перемешивание для эффекта лавины
        hash ^= length;
        hash ^= hash >> 33;
        hash *= prime4;
        hash ^= hash >> 29;
        hash *= prime1;
        hash ^= hash >> 32;

        return hash;
    }
}