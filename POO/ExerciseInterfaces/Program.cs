using ExerciseInterfaces;

SaveJson saveJson = new SaveJson();
SaveXml saveXml = new SaveXml();

Console.WriteLine("###################");
saveJson.Name();
saveJson.Save();

ISave save = new SaveJson(); //upcasting

save.Compress();
save.Save();

Console.WriteLine("\n###################");
saveXml.Name();
saveXml.Save();