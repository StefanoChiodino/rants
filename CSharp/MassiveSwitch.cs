private bool IndexItem(string name)
{
    switch (name.ToLower())
    {
        case "1":
            return false;
        case "2":
            return false;
        case "3":
            return false;
        case "4":
            return false;
        case "5":
            return false;
        case "6":
            return false;
        case "7":
            return false;
        case "8":
            return false;
        case "9":
            return false;
        case "10":
            return false;
        case "11":
            return false;
        case "12":
            return false;
        case "13":
            return false;
        case "14":
            return false;
        case "15":
            return false;
        case "16":
            return false;
        case "17":
            return false;
        case "18":
            return false;
        case "19":
            return false;
        case "20":
            return true;
        case "21":
            return false;
        case "22":
            return false;
        case "23":
            return false;
        case "24":
            return false;
    }

    return true;
}




// 56 lines, and you need to check line by line if your case is true or false. This is half the number of lines and more unambiguous.
private bool IndexItem(string name)
{
    switch (name.ToLower())
    {
        case "1":
        case "2":
        case "3":
        case "4":
        case "5":
        case "6":
        case "7":
        case "8":
        case "9":
        case "10":
        case "11":
        case "12":
        case "13":
        case "14":
        case "15":
        case "16":
        case "17":
        case "18":
        case "19":
        case "21":
        case "22":
        case "23":
        case "24":
            return false;
        default:
            return true;
    }
}



// Possibly a more expressive way still.
private bool IndexItem(string name)
{
    var list = new[]
    {
        "1",
        "2",
        "3",
        "4",
        "5",
        "6",
        "7",
        "8",
        "9",
        "10",
        "11",
        "12",
        "13",
        "14",
        "15",
        "16",
        "17",
        "18",
        "19",
        "21",
        "22",
        "23",
        "24",
        };

    return !list.Contains(name.ToLower());
}
