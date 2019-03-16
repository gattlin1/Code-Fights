enum Facing
    {
        Front,
        Left,
        Right,
        Back
    }

int lineUp(string commands)
{
    Facing confused_student = Facing.Front;
    Facing other_students = Facing.Front;
    int times_facing_same_way = 0;

    foreach(char command in commands)
    {
        if (command == 'L')
        {
            confused_student = turn_right(confused_student);
            other_students = turn_left(other_students);
        }
        else if (command == 'R')
        {
            confused_student = turn_left(confused_student);
            other_students = turn_right(other_students);
        }
        else if (command == 'A')
        {
            confused_student = turn_around(confused_student);
            other_students = turn_around(other_students);
        }
        if(students_facing_same_way(confused_student, other_students))
        {
            ++times_facing_same_way;
        }
    }
    return times_facing_same_way;
}

Facing turn_left(Facing prev_pos)
{
    Facing new_pos = prev_pos;
    if (prev_pos == Facing.Front)
    {
        new_pos = Facing.Left;
    }
    else if (prev_pos == Facing.Back)
    {
        new_pos = Facing.Right;
    }
    else if (prev_pos == Facing.Left)
    {
        new_pos = Facing.Back;
    }
    else if (prev_pos == Facing.Right)
    {
        new_pos = Facing.Front;
    }
    return new_pos;
}

Facing turn_right(Facing prev_pos)
{
    Facing new_pos = prev_pos;
    if (prev_pos == Facing.Front)
    {
        new_pos = Facing.Right;
    }
    else if (prev_pos == Facing.Back)
    {
        new_pos = Facing.Left;
    }
    else if (prev_pos == Facing.Left)
    {
        new_pos = Facing.Front;
    }
    else if (prev_pos == Facing.Right)
    {
        new_pos = Facing.Back;
    }
    return new_pos;
}

Facing turn_around(Facing prev_pos)
{
    Facing new_pos = prev_pos;
    if (prev_pos == Facing.Front)
    {
        new_pos = Facing.Back;
    }
    else if (prev_pos == Facing.Back)
    {
        new_pos = Facing.Front;
    }
    else if (prev_pos == Facing.Left)
    {
        new_pos = Facing.Right;
    }
    else if (prev_pos == Facing.Right)
    {
        new_pos = Facing.Left;
    }
    return new_pos;
}

bool students_facing_same_way(Facing confused_student, Facing other_students)
{
    return confused_student == other_students;
}