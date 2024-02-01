using Domain;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Repository;

public class CharacterRepository : IRepository<Character>
{
    private readonly GsaDbContext _context;

    public CharacterRepository(GsaDbContext context)
    {
        _context = context;
    }

    public async Task<Character> Add(Character entity)
    {
        var response = await _context.AddAsync(entity);
        _context.SaveChanges();

        return response.Entity;
    }

    public async Task<Character?> DeleteById(int id)
    {
        var character = await _context.Characters.FirstOrDefaultAsync(x => x.Id == id);
        
        if (character != null)
        {
            _context.Characters.Remove(character);
            await _context.SaveChangesAsync();
            return character;
        }

        return null;
    }

    public async Task<IEnumerable<Character?>> GetAll()
    {
        var characters = await _context.Characters.ToListAsync();

        return characters;
    }

    public async Task<Character?> GetById(int id)
    {
        var character = await _context.Characters.FirstOrDefaultAsync(x =>x.Id == id);

        return character;
    }

    public async Task<Character?> UpdateById(int id, Character entity)
    {
        var existingChar = await _context.Characters.FirstOrDefaultAsync(x => x.Id == id);

        if (existingChar == null)
            return null;

        var props = typeof(Character).GetProperties();

        foreach (var prop in props)
        {
            var existingCharValue = prop.GetValue(existingChar, null)!;
            var entityValue = prop.GetValue(entity, null)!;

            if (existingCharValue.ToString() != entityValue.ToString())
                prop.SetValue(existingChar, entityValue);
        }

        await _context.SaveChangesAsync();
        return existingChar;
    }

}
