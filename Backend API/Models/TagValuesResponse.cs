﻿namespace Backend_API.Models;

public class TagValuesResponse
{
    public Section? Section { get; set; }
    public List<TagValue>? Tags { get; set; }
}