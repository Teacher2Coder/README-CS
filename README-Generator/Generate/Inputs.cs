using System;
using System.Dynamic;

namespace README_Generator.Generate;

public sealed class Inputs
{
  private string? projectName;
  private string? githubUser;
  private string? email;
  private string? description;
  private string? install;
  private string? license;
  private string? contribute;
  private string? test;

  public string ProjectName
  {
    get { return projectName ?? string.Empty; }
    set { projectName = value; }
  }

  public string GithubUser
  {
    get { return githubUser ?? string.Empty; }
    set { githubUser = value; }
  }

  public string Email
  {
    get { return email ?? string.Empty; }
    set { email = value; }
  }

  public string Description
  {
    get { return description ?? string.Empty; }
    set { description = value; }
  }

  public string Install
  {
    get { return install ?? string.Empty; }
    set { install = value; }
  }

  public string License
  {
    get { return license ?? string.Empty; }
    set { license = value; }
  }

  public string Contribute
  {
    get { return contribute ?? string.Empty; }
    set { contribute = value; }
  }

  public string Test
  {
    get { return test ?? string.Empty; }
    set { test = value; }
  }

}