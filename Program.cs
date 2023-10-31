// See https://aka.ms/new-console-template for more information
using Robot;

Position position = new Position(); 
Helper.ReadIntialPosition(position);
while (true) { 
    Console.WriteLine("Select Your Option \n1 To Move \n2 for LEFT \n3 for RIGHT \n4 for REPORT");
    int value = Helper.ReadValueAsInt(1, 4, "Invalid Entry Please Enter 1 to 4");
    switch (value)
    {
        case 1: Helper.Move(position);
            break;
        case 2: 
            if ((int) position.Facing == 0)
                position.Facing = (Direction)3;
            else 
                position.Facing--;
            break;
        case 3: position.Facing++;
            break;
        case 4: Console.WriteLine("X= " + position.X + ",Y= " + position.Y + ",Facing= " + position.Facing);
            break;
    }
}