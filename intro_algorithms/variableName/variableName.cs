bool variableName(string name) {
    return name.All(o => char.IsLetterOrDigit(o) || o == '_') && !char.IsDigit(name[0]);
}