// System namespaces
global using System;
global using System.ComponentModel.DataAnnotations;
global using System.IO.Abstractions;
global using System.Reflection;
global using System.Text;
global using System.Text.Json;
global using System.Text.Json.Nodes;
global using System.Text.Json.Serialization;
global using System.Text.RegularExpressions;
global using System.Threading;
global using System.Threading.Tasks;
global using System.Xml.Linq;

// Microsoft extensions
global using Microsoft.Extensions.DependencyInjection;
global using Microsoft.Extensions.Logging;

// Third party packages
global using MediatR;

// Application namespaces
global using Mutations.Domain.Command;
global using Mutations.Domain.Entity;
global using Mutations.Domain.Enum;
global using Mutations.Domain.Interface;
