# Complete the solution so that it reverses the string passed into it.
# 'world'  =>  'dlrow'
# 'word'   =>  'drow'

def solution(string):
    s = ""
    for x in reversed(string):
        s+=x
    return s
    
print(solution("abc"))