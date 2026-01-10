using Microsoft.EntityFrameworkCore;
using BeFitMaui.Models;

namespace BeFitMaui.Data;

public class BeFitDbContext : DbContext
{
    public DbSet<ExerciseType> ExerciseTypes { get; set; }
    public DbSet<TrainingSession> TrainingSessions { get; set; }
    public DbSet<TrainingExercise> TrainingExercises { get; set; }
    public DbSet<User> Users { get; set; }

    public BeFitDbContext()
    {
        // Removed EnsureDeleted - database should be persistent now
        Database.EnsureCreated();
    }

    protected override void OnConfiguring(DbContextOptionsBuilder options)
    {
        var dbPath = Path.Combine(FileSystem.AppDataDirectory, "befit.db");
        options.UseSqlite($"Data Source={dbPath}");
    }
}
