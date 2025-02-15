//single line comment 

/* multi line comment
    if the player presses reload button
        if ammo count is equal to max ammo
            return and ignore
        else if we are missing ammo
            check how much is missing
            if extra ammo greater or equal to the amount needed
                top up gun ammo
                remove the missing value from the extra amo
            else 
                add the extra amo to the gun ammo
                set extra to 0 
    

    IF input R down
        IF _currentAmmo is equal to _maxAmmoCapacity
            RETURN
        ELSEIF _currentAmmo is less than _maxAmmoCapacity
            _ammoNeeded equals _maxAmmoCapacity minus _currentAmmo
            IF _reserveAmmo greater than or equal to _ammoNeeded
                _currentAmmo equals _currentAmmo plus _ammoNeeded
                _reserveAmmo equals _reserveAmmo minus _ammoNeeded
            ELSE _reserveAmmo greater than zero
                _currentAmmo equals _currentAmmo plus _reserveAmmo
                _reserveAmmo equals zero
            ELSE
                RETURN
            ENDIF
        ENDIF
    ENDIF
 */
using UnityEngine;
public class ReloadGun : MonoBehaviour
{
    [Header("Gun Ammo")]//lable for the variable below if visible in inspector
    [SerializeField] //allows you to see private variables in the inspector
    private int _currentAmmo = 8;
    [Range(0, 15)]//min max range slider best for floats for the variable below if visible in inspector
    [SerializeField]
    private int _maxAmmoCapacity = 10;
    [Space(10)]//creates a gap between variables that are visible in the inspector
    [SerializeField]
    private int _ammoNeeded = 0;
    [SerializeField]
    private int _reserveAmmo = 25;

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {

        }
        if (Input.GetKeyDown(KeyCode.R))
        {
            if (_currentAmmo == _maxAmmoCapacity)
            {
                return;
            }
            else if (_currentAmmo < _maxAmmoCapacity)
            {
                _ammoNeeded = _maxAmmoCapacity - _currentAmmo;
                if (_reserveAmmo >= _ammoNeeded)
                {
                    _currentAmmo = _currentAmmo + _ammoNeeded;
                    _reserveAmmo = _reserveAmmo - _ammoNeeded;
                }
                else if (_reserveAmmo > 0)
                {
                    _currentAmmo = _currentAmmo + _reserveAmmo;
                    _reserveAmmo = 0;
                }
                else
                {
                    return;
                }
            }
        }

    }
}
