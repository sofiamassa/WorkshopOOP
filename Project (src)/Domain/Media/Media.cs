using System;
using System.Collections.Generic;
public class Media
{
    public string title { get; set; }
}

public class EBook : Media
{
    public string author { get; set; }
    public string language { get; set; }
    public int numberOfPages { get; set; }
    public int publicationYear { get; set; }
    public string ISBN { get; set; }
}

public class Movies : Media
{
    public string director { get; set; }
    public string genres { get; set; }
    public int releaseYear { get; set; }
    public string language { get; set; }
    public int duration { get; set; }
}

public class Apps : Media
{
    public int version { get; set; }
    public string publisher { get; set; }
    public string supportedPlatforms { get; set; }
    public int fileSize { get; set; }
}

public class Podcasts : Media
{
    public int releaseYear { get; set; }
    public string host { get; set; }
    public string guest { get; set; }
    public int episode{ get; set; }
    public string language { get; set; }
}

public class Images : Media
{
    public string resolution { get; set; }
    public string fileFormat { get; set; }
    public int fileSize { get; set; }
    public int dateTaken { get; set; }
}

public class Songs : Media
{
    public string composer { get; set; }
    public string artist { get; set; }
    public string genre { get; set; }
    public string fileType { get; set; }
    public int duration { get; set; }
    public string language { get; set; }
}

public class VideoGames: Media
{
    public string genre { get; set; }
    public string publisher { get; set; }
    public int releaseYear { get; set; }
    public string supportedPlatforms { get; set; }
}