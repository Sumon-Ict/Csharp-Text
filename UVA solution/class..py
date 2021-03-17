class Person:
  def __init__(s, name, age):
    s.friend = name
    s.second = age
  def myfunc(s):
      print(s.friend,s.second)
    
p1 = Person("John", 36)
p1.myfunc()
