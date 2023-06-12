﻿using GraphQL.Demo.API.Schema.Queries;

namespace GraphQL.Demo.API.Schema.Mutations;

public class CourseInput
{ 
    public string Name { get; set; } = string.Empty;
    public Subject Subject { get; set; }
    public Guid InstructorId { get; set; }
}
