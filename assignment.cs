//Create a small program that prints the numbers from 1 to 100. 
//If the number is evenly divisible by 3, print "Fizz" instead of the number. If 5, "Buzz" 

For index As Integer = 1 To 100
    If index Mod 3 = 0 Then
	Debug.Write("Fizz")
    ElseIf index Mod 5 = 0 Then
	Debug.Write("Buzz")	
    Else
	Debug.Write(index.ToString & " ")
    End If
Next
Debug.WriteLine("")