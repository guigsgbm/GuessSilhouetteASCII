using Microsoft.AspNetCore.Mvc;
using Domain;
using Infrastructure.Repository;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using System.Text;

namespace CharacterAPI.Controllers;

[Route("api/characters")]
[ApiController]
public class CharacterController : ControllerBase
{
    private readonly CharacterRepository _characterRepository;
    public CharacterController(CharacterRepository characterRepository)
    {
        _characterRepository = characterRepository;
    }

    [HttpPost]
    public async Task<IActionResult> PostCharacterAsync([FromBody] Character character)
    {
        var response = await _characterRepository.Add(character);

        return Ok(response);
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> GetCharacterByIdAsync(int id)
    {
        var response = await _characterRepository.GetById(id);

        if (response != null)
            return Ok(response);

        return NotFound("No one character was found");
    }

    [HttpGet]
    public async Task<IActionResult> GetAllCharactersAsync()
    {
        var response = await _characterRepository.GetAll();

        if (response.Any() != false)
            return Ok(response);

        return NotFound("None character was found");
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> DeleteCharacterAsync(int id)
    {
        if (await _characterRepository.DeleteById(id) != null)
            return NoContent();

        return NotFound("Character not found");
    }

    [HttpPut("{id}")]
    public async Task<IActionResult> UpdateCharacterAsync([FromBody] Character character, int id)
    {
        var response = await _characterRepository.UpdateById(id, character);

        if (response != null)
            return Ok(response);

        return NotFound("Character not found");
    }
}
