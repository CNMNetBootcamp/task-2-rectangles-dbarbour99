//setup
    single area1 = 0;
    single area2 = 0;
    single height1 = 0;
    single width1 = 0;
    single height2 = 0;
    single width2 = 0;
    string duminput = string.Empty

//input

    //get height of first rectangle
    do 
        PUT "Input height of rectangle 1"
        GET strinput
        if strinput is not a number PUT "Please enter a number"
    while strinput is not a number
    GET height1 = single.parse(duminput)

    //get width of first rectangle
    do 
        PUT "Input width of rectangle 1"
        GET strinput
        if strinput is not a number PUT "Please enter a number"
    while strinput is not a number
    GET width1 = single.parse(duminput)

    
    //get height of second rectangle
    do 
        PUT "Input height of rectangle 2"
        GET strinput
        if strinput is not a number PUT "Please enter a number"
    while strinput is not a number
    GET height2 = single.parse(duminput)

    //get width of second rectangle
    do 
        PUT "Input width of rectangle 2"
        GET strinput
        if strinput is not a number PUT "Please enter a number"
    while strinput is not a number
    GET width2 = single.parse(duminput)

//processing
    
    area1 = height1 * width1
    area2 = height2 * width2
    
//output
    if (area1>area2) then
        PUT "The area of rectangle 1 (" + area1 + ") is larger than that or rectangle 2 (" + area2 + ")"
    else if (area2 > area1)
        PUT "The area of rectangle 2 (" + area2 + ") is larger than that or rectangle 1 (" + area1 + ")"
    else
        PUT "The areas of both rectangles are equal (" + area1 + ")"
