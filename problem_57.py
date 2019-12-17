"""
Given a string s and an integer k, break up the string into multiple lines such
that each line has a length of k or less. You must break it up so that words don't break across lines. 
Each line has to have the maximum possible amount of words. If there's no way to break the text up, then return null.

You can assume that there are no spaces at the ends of the string and that there is exactly one space between each word.

For example, given the string "the quick brown fox jumps over the lazy dog"
and k = 10, you should return: ["the quick", "brown fox", "jumps over", "the lazy", "dog"].
No string in the list has a length of more than 10.
"""

def breakLine(s,k):
    arr = s.split()

    output = []
    buffer_arr = []
    buffer_len = -1
    i = 0

    while i<len(arr):
        w = arr[i]
        if len(w) > k:
            print('\n[*] Cannot complete because of: "%s"' % w)
            return
        if (len(w) + buffer_len + 1) <=k:
            buffer_len += len(w) +1
            buffer_arr.append(w)
            i += 1
        else:
            result = ' '.join(buffer_arr)
            output.append(result)
            buffer_arr = []
            buffer_len = -1
    
    if buffer_arr:
        result = ' '.join(buffer_arr)
        output.append(result)
    return output

input = "the quick brown fox jumps over the lazy dog"
a = breakLine(input, k=10)
for i in a:
    print(i)
