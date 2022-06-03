test = """
         
           　 《 》
　  　    

　　　

　
　
　

"""

tlist = list(test)
s = []
for i in tlist :
  j = i
  if(i.encode('unicode-escape') == b'\\ue03c') :
    j = 'HQ'
  s.append(j)

print(s)

b = test.encode('unicode-escape')
print(b)

print(b.split('\\'))
