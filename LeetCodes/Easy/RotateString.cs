namespace LeetCode.LeetCodes.Easy
{
    public class RotateStringClass
    {
        public bool RotateString(string text, string goal)
        {
            if (text.Length == 0)
            {
                return goal.Length == 0;
            }

            if (text.Length != goal.Length)
            {
                return false;
            }

            string concatenated = text + text;

            return concatenated.Contains(goal);
        }

        //outras soluções
        public bool RotateStringManual(string text, string goal)
        {
            if (text.Length != goal.Length) return false;

            for (int i = 0; i < text.Length; i++)
            {
                string rotated = text.Substring(i) + text.Substring(0, i);

                if (rotated == goal)
                {
                    return true;
                }
            }

            return false;
        }

        public bool RotateStringArray(string text, string goal)
        {
            if (text.Length != goal.Length) return false;

            char[] arr = text.ToCharArray();

            for (int i = 0; i < arr.Length; i++)
            {
                RotateArray(arr);

                if (new string(arr) == goal)
                {
                    return true;
                }
            }

            return false;
        }

        private void RotateArray(char[] arr)
        {
            char first = arr[0];
            for (int i = 1; i < arr.Length; i++)
            {
                arr[i - 1] = arr[i];
            }
            arr[arr.Length] = first;
        }

        public bool RotateStringUsingIndexOf(string text, string goal)
        {
            if (text.Length != goal.Length) return false;
            return (text + text).IndexOf(goal) != -1;
        }

    }
}
