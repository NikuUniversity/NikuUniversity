namespace NikuUniversity.Web.Components.Data;

public static class UniversitySampleData
{
    public static IReadOnlyList<StatItem> Stats { get; } = new List<StatItem>
    {
        new("98%", "Graduate Employment"),
        new("24/7", "Learning Support"),
        new("12", "Global Partnerships")
    };

    public static IReadOnlyList<ProgramItem> FeaturedPrograms { get; } = new List<ProgramItem>
    {
        new("Computer Science", "Design AI products, build modern software, and launch startup ideas.", "3 years", "STEM"),
        new("Business & Innovation", "Turn strategy into impact with hands-on consulting and leadership labs.", "4 years", "Business"),
        new("Digital Media", "Create meaningful campaigns, films, and immersive brand experiences.", "3 years", "Arts")
    };

    public static IReadOnlyList<CampusHighlight> CampusHighlights { get; } = new List<CampusHighlight>
    {
        new("Innovation Labs", "Work in maker spaces equipped for robotics, media, and design challenge studios."),
        new("Global Exchange", "Join student exchange programs in Europe, Asia, and North America."),
        new("Mentor Network", "Learn directly from faculty founders, alumni leaders, and industry partners.")
    };

    public static IReadOnlyList<AdmissionStep> AdmissionSteps { get; } = new List<AdmissionStep>
    {
        new("1. Apply", "Submit your academic profile and personal statement."),
        new("2. Interview", "Meet with an admissions advisor and academic mentor."),
        new("3. Enroll", "Secure your place and begin your first semester orientation.")
    };

    public static IReadOnlyList<Testimonial> Testimonials { get; } = new List<Testimonial>
    {
        new("Mina, Computer Science", "The project-based approach helped me build a portfolio before graduation."),
        new("Daniel, Business & Innovation", "The mentorship culture made every challenge feel possible and practical."),
        new("Ava, Digital Media", "I found a creative community that supported both my ambition and growth.")
    };
}

public sealed record StatItem(string Value, string Label);
public sealed record ProgramItem(string Name, string Description, string Duration, string Category);
public sealed record CampusHighlight(string Title, string Description);
public sealed record AdmissionStep(string Step, string Description);
public sealed record Testimonial(string Name, string Quote);
