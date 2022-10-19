# SampleFEFO

FEFO (First Expired First Out) - struct of data, that stores various elements with expiration date. If element has expired, it will remove first.

I didn't see samples of this struct in the Web, so I made analogue.

Program has visual GUI, based on WinForms and C#

![image](https://user-images.githubusercontent.com/49618224/196601892-c478a7be-e3c1-4537-afcc-de08d6fe6e58.png)

You can add elements in the list, set date, view items, check expiration date and delete expired elements (at that moment 19th October 2022)

![image](https://user-images.githubusercontent.com/49618224/196603290-ea5ce98c-c66d-444d-8e3a-9c31999c943d.png)

If you want to add already expired elements, you can set CheckBox "Allow to add expired values" and program will add one. Else you will get the error

![image](https://user-images.githubusercontent.com/49618224/196603174-0db79766-bf7b-43ae-9c4b-d4ecf3e24b05.png)


Products list represents collection with generic parameter. Also ProductsList class is container, that contains elements of Product class.
