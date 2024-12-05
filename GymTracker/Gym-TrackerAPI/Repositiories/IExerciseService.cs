using GymTrackersAPI.Entities;


namespace GymTrackerAPI.Repositiories

{
    public interface IExerciseService
    {
        Task<IEnumerable<Exercise>?> ExerciseGetAll(int exercise_id);

        // Task<int> ExerciseAdd(Exercise exercise);
        Task<IEnumerable<Exercise>> ExerciseGetEquipment(int exercise_id);
    }
}
