# Проблема 2. SyntaxError: invalid syntax

msg = True
if msg = True:
    print("Приветственное сообщение")
# Ошибка:
# SyntaxError: invalid syntax
# не верно выбрано True

msg = True
if msg == True:
    print("Приветственное сообщение")
